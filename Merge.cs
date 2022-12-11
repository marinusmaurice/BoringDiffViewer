//Author: Maurice Marinus
//Licence: MIT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDiffViewer
{
    internal enum MatchPer
    {
        Character,
        Word,
        Line,
        Sentence
    }

    internal class Merged
    {
        public Merged()
        {
            BothColor = Color.White;
            LeftColor = Color.Green;
            RightColor = Color.Red;
            Right = string.Empty;
            Left = string.Empty;
            MatchPer = MatchPer.Word;
        }
        public string Left { get; set; }
        public string Right { get; set; }

        public Color LeftColor { get; set; }
        public Color RightColor { get; set; }
        public Color BothColor { get; set; }

        public MatchPer MatchPer { get; set; }

        public List<OutputItem> Diff()
        {
            List<OutputItem> result = new List<OutputItem>();
            uint pos = 0;
            bool endofs1 = false;
            bool endofs2 = false;
            Queue<string> s1s = new Queue<string>();
            Queue<string> s2s = new Queue<string>();
            bool initialCompare = true;
            SplitData(Left, Right, ref s1s, ref s2s);

            string s1Cur = s1s.Dequeue();
            string s2Cur = s2s.Dequeue();
            while (!endofs1 || !endofs2)
            {
                if (!endofs1 && endofs2)
                { 
                    result.Add(new OutputItem(pos++, s1Cur, WhereIn.Left));
                    endofs1 = !s1s.TryDequeue(out s1Cur); 

                }
                else if (endofs1 && !endofs2)
                { 
                    result.Add(new OutputItem(pos++, s2Cur, WhereIn.Right));
                    endofs2 = !s2s.TryDequeue(out s2Cur); 
                }
                else
                {
                    if (s1Cur == s2Cur)
                    { 
                        result.Add(new OutputItem(pos++, s1Cur, WhereIn.Both));
                        endofs1 = !s1s.TryDequeue(out s1Cur);
                        endofs2 = !s2s.TryDequeue(out s2Cur);
                        initialCompare = true;
                    }
                     
                    else if (s1Cur != s2Cur && (initialCompare))
                    {
                        var g1 = s1s.ToList().Prepend(s1Cur);
                        s1s = new Queue<string>(g1);

                        var g2 = s2s.ToList().Prepend(s2Cur);
                        s2s = new Queue<string>(g2);

                        var t1 = s1s.ToList().Distinct();
                        var t2 = s2s.ToList().Distinct();
                        var p = t1.Intersect(t2);

                        //Output everything up until the first intersecting value
                        if (p.Count() > 0)
                        { 
                            string matchingText = p.ElementAt(0); 
                           
                            while (!(endofs1 = !s1s.TryDequeue(out s1Cur)))
                            {
                                if (s1Cur != matchingText)
                                { 
                                    result.Add(new OutputItem(pos++, s1Cur, WhereIn.Left)); 
                                }
                                else
                                { 
                                    break;
                                }
                            } 
                            while (!(endofs2 = !s2s.TryDequeue(out s2Cur)))
                            {
                                if (s2Cur != matchingText)
                                { 
                                    result.Add(new OutputItem(pos++, s2Cur, WhereIn.Right)); 
                                }
                                else
                                { 
                                    break;
                                }
                            }
                        }
                        else
                        {
                            endofs1 = !s1s.TryDequeue(out s1Cur);
                            endofs2 = !s2s.TryDequeue(out s2Cur);

                            do
                            { 
                                result.Add(new OutputItem(pos++, s1Cur, WhereIn.Left));
                            } while (!(endofs1 = !s1s.TryDequeue(out s1Cur)));

                            do
                            { 
                                result.Add(new OutputItem(pos++, s2Cur, WhereIn.Right));
                            } while (!(endofs2 = !s2s.TryDequeue(out s2Cur)));
                        } 
                    }
                }
            }

            return result;
        }

        public bool Test(List<OutputItem> items, WhereIn whereIn)
        {
            StringBuilder sb = new StringBuilder();
            bool result1 = false;
            bool result2 = false;
            if (whereIn == WhereIn.Left || whereIn == WhereIn.Both)
            {
                var k = items.Where(x => x.WhereIn == WhereIn.Both || x.WhereIn == WhereIn.Left).ToList();
                foreach (var item in k)
                {  
                    sb.Append(item.Value);
                }
                result1 = sb.ToString() == Left;
            }
            sb.Clear();
            if (whereIn == WhereIn.Right || whereIn == WhereIn.Both)
            {
                var k = items.Where(x => x.WhereIn == WhereIn.Both || x.WhereIn == WhereIn.Right).ToList();
                foreach (var item in k)
                {
                    sb.Append(item.Value);
                }
                result2 = sb.ToString() == Right;
            }

            switch (whereIn)
            {
                case WhereIn.Both:
                    return result1 & result2;
                    break;
                case WhereIn.Left:
                    return result1;
                    break;
                case WhereIn.Right:
                    return result2;
                    break; 
            }

            return false;
        }

        private void SplitData(string s1, string s2, ref Queue<string> s1s, ref Queue<string> s2s)
        {
            switch (MatchPer)
            {
                case MatchPer.Character:
                    { 
                        MakeQueue(s1, string.Empty, ref s1s);
                        MakeQueue(s2, string.Empty, ref s2s);
                        break;
                    }
                case MatchPer.Word:
                    { 
                        MakeQueue(s1, " ", ref s1s);
                        MakeQueue(s2, " ", ref s2s);
                        break;
                    }
                case MatchPer.Line:
                    { 
                        MakeQueue(s1, System.Environment.NewLine, ref s1s);
                        MakeQueue(s2, System.Environment.NewLine, ref s2s);
                        break;
                    }
                case MatchPer.Sentence:
                    {
                        MakeQueue(s1, ".", ref s1s);
                        MakeQueue(s2, ".", ref s2s);
                        break;
                    }
            } 
        }

        private void MakeQueue(string s, string splitChar, ref Queue<string> ss)
        {
            List<string> j = new List<string>();
            if (splitChar == string.Empty || (MatchPer == MatchPer.Character))
            {
                foreach (var ch in s)
                {
                    j.Add(ch.ToString());
                }
            }
            else
                j = s.Split(new string[] { splitChar }, StringSplitOptions.None).ToList();

            for (int x = 0; x < j.Count(); x++)
            {
                if (x < (j.Count() - 1))
                    ss.Enqueue(j[x].ToString() + splitChar);
                else
                    ss.Enqueue(j[x].ToString());
            }
        }
    }

    internal class OutputItem
    {
        public OutputItem(uint position, string value, WhereIn whereIn)
        {
            Position = position;
            Value = value;
            WhereIn = whereIn;
        }
        public uint Position { get; set; }
        public string Value { get; set; }
        public WhereIn WhereIn { get; set; }
    }

    internal enum WhereIn
    {
        Both,
        Left,
        Right
    }

    internal enum Algorithm
    {
        FirstIntersectValue,
        LongestCommonValue
    }
}

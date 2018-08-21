using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Analytics.Models
{
    public class homona
    {
        public string Gurum { get; set; } = string.Empty;
        public string lowGurum { get; set; }

        public void Run(int k)
        {
            int i = 0;
            int c = 0;
            for (; i < 10; i++)
            {
                c++;
            }
        }

        public void badFun()
        {
            int q = 0;
            int w = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        for (int l = 0; l < 20; l++)
                        {
                            w++;
                        }
                    }
                }
            }
        }
    }
}
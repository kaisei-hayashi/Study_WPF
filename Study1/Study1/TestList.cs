using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class TestList
    {
        public List<Test> Data { get; }

        public TestList()
        {
            Data = new List<Test> {
                new Test {Subj = "国語", Points = 50, Name = "田中", ClassName = "A"},
                new Test {Subj = "数学", Points = 50, Name = "吉田", ClassName = "B"},
                new Test {Subj = "英語", Points = 50, Name = "佐藤", ClassName = "A"}
           };
        }
    }
}

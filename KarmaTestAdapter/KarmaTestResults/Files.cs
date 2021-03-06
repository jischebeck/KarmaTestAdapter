﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KarmaTestAdapter.KarmaTestResults
{
    public class Files : TestCaseContainer, IEnumerable<File>
    {
        public Files(Item parent, XElement element)
            : base(parent, element)
        {
        }

        public IEnumerator<File> GetEnumerator()
        {
            return Children.OfType<File>().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

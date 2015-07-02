using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyphsteps.models.cyphers
{
    public class Cypher
    {
        public Cypher() {}

        public string convertText(string text)
        {
            text = text.Replace("-_-",":.:");
            return text;
        }
    }

    public class Decypher
    {
        public Decypher() {}

        public string convertText(string text)
        {
            text = text.Replace(":.:", "-_-");
            return text;
        }
    }
}

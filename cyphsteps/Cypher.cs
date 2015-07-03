using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyphsteps.models.cyphers
{
    public class Cypher
    {
        private byte[] deco_bytes;
        private string deco_text;
        private byte[] bytes;
        private string text;
        private string enco_text;
        private byte[] enco_bytes;

        public Cypher() 
        {
            text = string.Empty;
            enco_text = string.Empty;
            deco_text = string.Empty;
        }

        public string encode(string text)
        {
            this.text = text;
            enco_bytes = bytes = ParseBytes(text);

            for (int i = 0; i < enco_bytes.Length; i++)
            {
                if (enco_bytes[i] > 0)
                    enco_bytes[i] += 2;
                enco_text += Convert.ToString(enco_bytes[i]) + " ";
            }

            return enco_text;
        }

        public string decode(byte[] bytes)
        {
            deco_bytes = bytes;
            deco_text = ParseString(this.bytes);

            for (int i = 0; i < deco_bytes.Length; i++)
            {
                if (deco_bytes[i] > 0)
                    deco_bytes[i] -= 2;
                deco_text += Convert.ToString(deco_bytes[i]) + " ";
            }

            return deco_text;
        }

        private byte[] ParseBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private string ParseString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public byte[] GetBytes()
        {
            return bytes;
        }

        public byte[] GetDecodedBytes()
        {
            return deco_bytes;
        }

        public byte[] GetEncodedBytes()
        {
            return enco_bytes;
        }

        public string GetEncodedText()
        {
            return enco_text;
        }

        public string GetDecodedText()
        {
            return deco_text;
        }

        public string GetText()
        {
            return text;
        }
    }
}

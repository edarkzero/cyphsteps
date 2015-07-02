using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyphsteps.models.cyphers
{
    public class Cypher
    {
        private byte[] bytes;
        private string text;

        public Cypher() 
        {
            text = string.Empty;
        }

        public string convertText(string text)
        {
            bytes = GetBytes(text);

            for (int i = 0; i < bytes.Length; i++ )
            {
                bytes[i] += 2;
                this.text += Convert.ToString(bytes[i]) + " ";
            }

            return this.text;
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public byte[] GetBytes()
        {
            return bytes;
        }
    }

    public class Decypher
    {
        private string text;
        private byte[] bytes;

        public Decypher() 
        {
            text = string.Empty;
        }

        public string convertText(byte[] bytes)
        {
            this.bytes = bytes;
            text = GetString(this.bytes);
            return text;
        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}

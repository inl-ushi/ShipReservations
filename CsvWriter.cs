using System;
using System.Text;

namespace ShipReservations
{
    internal class CsvWriter
    {
        private string filePath;
        private Encoding encoding;

        public CsvWriter(string filePath, Encoding encoding)
        {
            this.filePath = filePath;
            this.encoding = encoding;
        }

        internal void WriteLine(string[] values)
        {
            throw new NotImplementedException();
        }
    }
}
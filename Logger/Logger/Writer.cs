using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Writer
    {
        internal string log;
        internal string emne;
        string NL = Environment.NewLine;
        string dato = DateTime.Now.ToString("dd"+"-"+"MM"+"-"+"yyyy") + ".txt";
        internal void _Logger(string _log, string _emne)
        {
            log = _log;
            emne = _emne;
            StreamWriter logfile;
            logfile = File.AppendText(emne+" "+dato);
            logfile.Write(log);
            logfile.Close();
        }
    }
}

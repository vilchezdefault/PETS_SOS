using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.TOOLS
{
    public class writeLog
    {
        public static string menssagesLog { get; set; }
        public static Boolean showConsole { get; set; }

        //Constructor si se pasa el mensaje por parámetro en la creación de la clase
        public writeLog(string mssSend, Boolean showConsole)
        {
            menssagesLog = mssSend;
            if (showConsole)
                showmessageConsole();
            writeLineBook();
        }
        //Constructor si se pasa el mensaje por setter tras la creación de la clase
        public writeLog()
        {
            if (showConsole)
                showmessageConsole();
            writeLineBook();
        }

        public void showmessageConsole()
        {
            //Quitar posibles saltos de línea del mensaje
            menssagesLog = menssagesLog.Replace(Environment.NewLine, " | ");
            menssagesLog = menssagesLog.Replace("\r\n", " | ").Replace("\n", " | ").Replace("\r", " | ");
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + menssagesLog);
        }

        public void writeLineBook()
        {
            try
            {
                FileStream fs = new FileStream(@AppDomain.CurrentDomain.BaseDirectory +
                  "bitacora.log", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                //Quitar posibles saltos de línea del mensaje
                menssagesLog = menssagesLog.Replace(Environment.NewLine, " | ");
                menssagesLog = menssagesLog.Replace("\r\n", " | ").Replace("\n", " | ").Replace("\r", " | ");
                m_streamWriter.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + menssagesLog);
                m_streamWriter.Flush();
                m_streamWriter.Close();
            }
            catch
            {

                throw;
            }
        }
    }
}

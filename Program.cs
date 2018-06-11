using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heursayexe
{
    static class Program
    {
        private static string label11;
        private static bool fh;
        private static int yu;
        public static System.Speech.Synthesis.SpeechSynthesizer saytd = new System.Speech.Synthesis.SpeechSynthesizer();
        private static string ftg;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("Bienvenue sur le programe Pour la Compagnie" + Environment.NewLine + "nous sommes fier de vous presenter" + Environment.NewLine + " linterface avec intelligence artificiel" + Environment.NewLine + "elle peut apprendre evoluer et changer");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("Creer par : YAN BERGERON");
            Console.WriteLine("--------");

            string fth = File.ReadAllText("directory.tx");
            ftg = fth;
            System.IO.Directory.SetCurrentDirectory(fth);
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(ftg);
                Environment.CurrentDirectory = ftg;

                Properties.Settings.Default.Save();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
            // Print to console the results.
            Console.WriteLine("Root directory: {0}", Directory.GetDirectoryRoot(ftg));
            Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());



            try
            {
                string myHost = System.Net.Dns.GetHostName();
                string myIP = null;

                for (int i = 0; i <= System.Net.Dns.GetHostEntry(myHost).AddressList.Length - 1; i++)
                {
                    if (System.Net.Dns.GetHostEntry(myHost).AddressList[i].IsIPv6LinkLocal == false)
                    {
                        myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[i].ToString();
                    }
                }
                Console.WriteLine("--------");
                Console.WriteLine("local ip : " + myIP);
                var xg = Environment.SystemPageSize;
                Console.WriteLine("--------");
                Console.WriteLine("memory paging loaded : " + xg);
                string[] sss = Environment.GetLogicalDrives();
                Console.WriteLine("logical drives : ");
                foreach (string bf in sss)
                {
                    Console.Write(bf);
                }
                var stt = Environment.MachineName;
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.WriteLine("machinne name : " + stt);
                int tre = Environment.ProcessorCount;
                Console.WriteLine("--------");
                Console.WriteLine("processor count : " + tre);

                var sut = Environment.UserDomainName;
                Console.WriteLine("--------");
                Console.WriteLine("network name : " + myHost);
                var scx = Environment.UserName;
                Console.WriteLine("--------");
                Console.WriteLine("user name : " + scx);
                var syr = Environment.Version;
                Console.WriteLine("--------");
                var syre = Environment.OSVersion;
                Console.WriteLine("os ver : " + syre);
                Console.WriteLine("--------");
                Console.WriteLine("ver : " + syr);
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                Console.WriteLine("--------");
                Console.WriteLine("ip adress : " + externalip);

                Console.WriteLine("--------");

                var sfg = Environment.UserInteractive;
                Console.WriteLine("interactif : " + sfg);
            }
            catch { Console.WriteLine("error environement"); }


            Thread hsdf = new Thread(pb);
            hsdf.Start();

        }
        public static void sayt(string h)
        {
            try
            {
                Console.WriteLine(h);
                saytd.SelectVoice("Microsoft Hortense Desktop");
                saytd.SpeakAsync(h);

            }
            catch { }
        }
        public static void pb()
        {
            do
            {
                DateTime now = DateTime.Now;
                label11 = now.ToString("mm.ss");
                string jm = label11;

                if (File.Exists("heursay.txt"))
                {

                    string[] pjl = File.ReadAllLines("heursay.txt");
                    Application.DoEvents(); foreach (string ft in pjl)
                    {
                        if (!fh)
                        {

                            if (now.Hour >= 5 && now.Hour < 12)
                            {
                                if (ft.Contains("matin"))
                                {
                                    string tff = ft.Replace("matin", "");
                                    if (tff.Contains(jm))
                                    {
                                        yu++;
                                        if (yu <= 1)
                                        {
                                            string fb = tff.Replace(jm, "");
                                            if (fb.Contains("false"))
                                            {
                                                fh = true;
                                                yu++;
                                                string fbc = fb.Replace("false", "");
                                                sayt(fbc);
                                                break;
                                            }
                                            else
                                            if (fb.Contains("true"))
                                            {
                                                fh = true;
                                                yu++;
                                                string vc = fb.Replace("true", "");

                                                sayt(vc);

                                                Console.Beep();
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                    else
                                    {
                                        fh = false;
                                    }

                                }
                            }
                            if (now.Hour >= 12 && now.Hour < 18)
                            {
                                if (ft.Contains("midi"))
                                {
                                    string tff = ft.Replace("midi", "");
                                    if (tff.Contains(jm))
                                    {
                                        yu++;
                                        if (yu <= 1)
                                        {
                                            string fb = tff.Replace(jm, "");
                                            if (fb.Contains("false"))
                                            {
                                                fh = true;
                                                yu++;
                                                string fbc = fb.Replace("false", "");
                                                sayt(fbc);
                                                break;
                                            }
                                            else
                                            if (fb.Contains("true"))
                                            {
                                                fh = true;
                                                yu++;
                                                string vc = fb.Replace("true", "");

                                                sayt(vc);

                                                Console.Beep();
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                    else
                                    {
                                        fh = false;
                                    }
                                }
                            }
                            if (now.Hour >= 18 && now.Hour < 24)
                            {
                                if (ft.Contains("soir"))
                                {
                                    string tff = ft.Replace("soir", "");
                                    if (tff.Contains(jm))
                                    {
                                        yu++;
                                        if (yu <= 1)
                                        {
                                            string fb = tff.Replace(jm, "");
                                            if (fb.Contains("false"))
                                            {
                                                fh = true;
                                                yu++;
                                                string fbc = fb.Replace("false", "");
                                                sayt(fbc);
                                                break;
                                            }
                                            else
                                            if (fb.Contains("true"))
                                            {
                                                fh = true;
                                                yu++;
                                                string vc = fb.Replace("true", "");

                                                sayt(vc);

                                                Console.Beep();
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                    else
                                    {
                                        fh = false;
                                    }
                                }
                            }
                            if (now.Hour < 5)
                            {

                                if (now.Hour >= 5 && now.Hour < 12)
                                {
                                    if (ft.Contains("nuit"))
                                    {
                                        string tff = ft.Replace("nuit", "");
                                        if (tff.Contains(jm))
                                        {
                                            yu++;
                                            if (yu <= 1)
                                            {
                                                string fb = tff.Replace(jm, "");
                                                if (fb.Contains("false"))
                                                {
                                                    fh = true;
                                                    yu++;
                                                    string fbc = fb.Replace("false", "");
                                                    sayt(fbc);
                                                    break;
                                                }
                                                else
                                                if (fb.Contains("true"))
                                                {
                                                    fh = true;
                                                    yu++;
                                                    string vc = fb.Replace("true", "");

                                                    sayt(vc);

                                                    Console.Beep();
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                break;
                                            }


                                        }
                                        else
                                        {
                                            fh = false;
                                        }

                                    }
                                }
                            }

                        }
                        else
                        {
                            yu++;
                            fh = false;
                        }






                    }
                    yu = 0;
                }

                Thread.Sleep(500);
            } while (true);
        }
    }
}

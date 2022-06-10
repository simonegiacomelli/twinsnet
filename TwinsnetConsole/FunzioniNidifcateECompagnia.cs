using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    public class FunzioniNidifcateECompagnia
    {
        public static void Main(string[] args)
        {
            var istanza = new FunzioniNidifcateECompagnia();
            istanza.FunzioneNidificata();
            istanza.LambdaComeFunzioneNidificata();
            istanza.EsercitaLambda();
            istanza.EsercitaLambdaSuDispositivi();
        }

        private void EsercitaLambdaSuDispositivi()
        {
            var dispositivi = Dispositivo.NuovaListaDispositiviDiEsempio();
            var setDispositivi = new HashSet<int> { 2, 5 };
            var dispositiviId = dispositivi.Select(dispositivi => dispositivi.Id).ToHashSet();

            var x = dispositiviId.Except(setDispositivi); // 1, 3, 4

        }

        private void EsercitaLambda()
        {
            var list1 = new List<int> { 1, 2, 3 };
            Lambda(list1, (e) => e + 1);
            LogList("con lambda `(e) => e + 1`", list1);
            Lambda(list1, (int e) => e * 2);
            LogList("con lambda `(e) => e * 2`", list1);
        }

        private void LogList(string msg, List<int> list)
        {
            Console.WriteLine($"{msg} {String.Join(", ", list)}");
        }

        private void Lambda(List<int> punteggio, Func<int, int> processaElemento)
        {
            for (int i = 0; i < punteggio.Count; i++)
            {
                punteggio[i] = processaElemento(punteggio[i]);
            }
        }


        private void FunzioneNidificata()
        {
            int stepCounter = 0;
            void Log(string msg)
            {
                stepCounter++;
                Console.WriteLine($"{nameof(FunzioneNidificata)} - step {stepCounter} - " + msg);
            }

            Log("inizializzazione");

            Log("apertura valvola");

        }

        private void LambdaComeFunzioneNidificata()
        {
            int stepCounter = 0;
            Action<string> Log = (string msg) =>
                        {
                            stepCounter++;
                            Console.WriteLine($"{nameof(LambdaComeFunzioneNidificata)} - step {stepCounter} - " + msg);
                        };

            Log("inizializzazione");

            Log("apertura valvola");

        }



    }
}

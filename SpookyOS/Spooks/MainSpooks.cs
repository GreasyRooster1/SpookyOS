using Cosmos.HAL.Drivers.PCI.Audio;
using Cosmos.System.Audio;
using Cosmos.System.Audio.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpookyOS.Spooks
{
    public class MainSpooks
    {
        public static void basicSpook()
        {
            //Im so sorry, audio drivers are too complicated and its almost midnight
            //maybe in V2.0?
            /*var mixer = new AudioMixer();
            var audioStream = MemoryAudioStream.FromWave(SpookData.jumpscare);
            var driver = AC97.Initialize(bufferSize: 4096);
            mixer.Streams.Add(audioStream);

            var audioManager = new AudioManager()
            {
                Stream = mixer,
                Output = driver
            };
            audioManager.Enable();*/

            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(SpookData.basicSpookText);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(SpookData.basicSpookText);
                }
                Thread.Sleep(7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(SpookData.basicSpookText);
                Thread.Sleep(7);
            }
            Console.Clear();
        }
    }
}

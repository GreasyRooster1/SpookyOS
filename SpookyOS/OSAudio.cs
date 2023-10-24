using Cosmos.HAL.Drivers.PCI.Audio;
using Cosmos.System.Audio.IO;
using Cosmos.System.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL.Audio;

namespace SpookyOS
{
    public class OSAudio
    {
        public static AudioMixer mixer = new AudioMixer();
        public static AudioDriver driver = AC97.Initialize(bufferSize: 4096);
        public static AudioManager audioManager = new AudioManager()
        {
            Stream = mixer,
            Output = driver
        };
        public static void Setup()
        {
            audioManager.Enable();
        }
    }
}

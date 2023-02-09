using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HardyCorentin
{

    [CreateAssetMenu(fileName = "NewMusic", menuName = "Musique", order = 0)]
    public class TestCreaMusique : ScriptableObject
    {
        public AudioClip track;
        public int bpm;
        public string nom;
        public string nomArtiste;
        public Sprite jaquette;
    }
}
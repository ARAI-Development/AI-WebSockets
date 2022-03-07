using System;
using System.Collections.Generic;
using System.Text;

namespace The_ARAI_Project
{
    class CharacterClass
    {

        public string gender { get; set; }

        public string coordinates { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public float leftRotationDeg { get; set; }

        public float rightRotationDeg { get; set; }

        public float topRotationDeg { get; set; }

        public float bottomRotationDeg { get; set; }

        public string feelings { get; set; } //array of objects

        public string relatives { get; set; }//array of objects(Character Classes)

        public string memory { get; set; }//array of objects representing the AI's memory

        public string hairColor { get; set; } //should be a hex value

        public string eyeColor { get; set; }//should be hex value

        public long ID { get; set; } 

        public string currentWorldSimulation { get; set; } //represents the current view of the AI

        public string charactersNearby { get; set; } //array of objects(Character Classes) 

        public string items { get; set; } //array of objects 

        public int health { get; set; } //0-100

        public string characterModel { get; set; } //The 3D model of the AI's character(Cloud URL)

    }
}

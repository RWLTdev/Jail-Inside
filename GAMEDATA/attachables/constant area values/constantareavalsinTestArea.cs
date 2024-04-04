using Godot;
using System;
using System.Collections.Generic;

public partial class constantareavalsinTestArea : Node
{
    //TEST AREA CONSTANT VALUES INTERCHANGEABLE
    //Party's over no more statics eg. interface necessitated

    //music track names, music track paths, ((current music track)), BPM values, 
    public struct cvMusicTrack
    {
        public string Name;
        public string FilePath;
        public float BPM;

        public float StartTrimValue;
        public float EndTrimValue;

        //constructorsss babyyyyyy
        public cvMusicTrack(string name, string filepath, float bpm, float starttrimvalue, float endtrimvalue) //add custom startbeforebeat offset for dead space and custom beat to start the ready set go on
        {
            Name = name;
            FilePath = filepath;
            BPM = bpm;
            StartTrimValue = starttrimvalue;
            EndTrimValue = endtrimvalue;
        }
    }       
            //randomizer list ((change to be used on zone load eventually))
            public Dictionary<string, cvMusicTrack> MusicTrackList = new Dictionary<string, cvMusicTrack>
            {
                { "DealEmOut", new cvMusicTrack ("Deal 'Em Out", "res://ALLTEMP stuffstorage/assets/audio/music/Deal 'Em Out.mp3", 120.0f, 0.0f, 0.0f) },
                //{ "GetEnuf", new cvMusicTrack ("GET ENUF", "res://ALLTEMP stuffstorage/assets/audio/music/GET ENUF.mp3", 135.74555f, 0.0f, 0.0f) },
                { "Crypteque", new cvMusicTrack ("Crypteque", "res://ALLTEMP stuffstorage/assets/audio/music/Crypteque.mp3", 130.0f, 0.0f, 0.0f) },
            };

     //bg element node arrangements in coords from the bgparent/ close/medium/far,
    public struct BackgroundElementNodeArrangements
    {
        public enum Distance{Close, Medium, Far}
    }
     //texture and animation info, filepath...

    public struct BackgroundElementNodeData
    {
        public string FileName;
    }

    string currentarea = playerdataA.playercurrentarea; dynamic thistrackselected;      
    public void onMusicPickerRequest(string action)
    {
        Node Musicpicker = GetNode("/root/Root3D/LogicParent/GameLogic/DJ");
        switch (action)
        {
            case "pickrandomtrack":
                //Get struct/dict and randomly pick a track inside its dict
                List<string> keys = new List<string>(MusicTrackList.Keys);
				Random random = new Random();
				int randomIndex = random.Next(keys.Count);
				string randomKey = keys[randomIndex];
				cvMusicTrack getstruct = MusicTrackList[randomKey];
				thistrackselected = getstruct;

                //send the info back to musicpickerRequest
                Musicpicker.Call("returnAreaConstantValsTrack", thistrackselected.FilePath, thistrackselected.BPM, thistrackselected.StartTrimValue, thistrackselected.EndTrimValue);
            break;
        }
    }
    
}

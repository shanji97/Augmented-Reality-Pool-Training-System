using System.Collections.Generic;

public  class Classification
{
    public Classification(short osVersion)
    {
        ChangeClassificatorsBasedOnVersion(osVersion);
    }

    const short baseOsVersion = 72;
    public const string Floor = "FLOOR";
    public const string Ceiling = "CEILING";
    public const string WallFace = "WALL_FACE";
    public const string Desk = "DESK";
    public const string Couch = "COUCH";
    public const string DoorFrame = "DOOR_FRAME";
    public const string WindowFrame = "WINDOW_FRAME";
    public const string Other = "OTHER";
    public const string Storage = "STORAGE";
    public const string Bed = "BED";
    public const string Screen = "SCREEN";
    public const string Lamp = "LAMP";
    public const string Plant = "PLANT";

    public static List<string> classifications = new (){
        Floor,
        Ceiling,
        WallFace,
        Desk,
        Couch,
        DoorFrame,
        WindowFrame,
        Other,
        Storage,
        Bed,
        Screen,
        Lamp,
        Plant
    };

    public static bool IsValidClassification(string classification){
        return classifications.Contains(classification);
    }

    public static void ChangeClassificatorsBasedOnVersion(short osVersion){
       if(osVersion < baseOsVersion){
         throw new System.Exception("OS version is too low. Please update the Quest 3 headset to use the latest version.");
       }

       //For each supported version track the changes and update the classifications list.
       //Loop through the versions and update the classifications list.
       var nothingToUpdate = false;
       for(var i = baseOsVersion; i <= osVersion; i++){
            switch (i)
            {
                case 74: break;
                case 72: break;
                default:
                    nothingToUpdate = true;
                break;
            }

            if(nothingToUpdate)
                return;
       }
    }
}
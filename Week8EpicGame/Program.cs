string folderPath = @"C:\Users\Admin\Documents\Sigrit\Kool\teinekursus\Kevad\Programmeerimine\data\"; //see faili aadress on sõne
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile)); //PathCombine kleebib teksti väärtused kokku, võtab faili asukoha erinevad komponendid ja kleebib need kokku õigel kujul, lisab vajalikud kaldkriipsud, sõltuvalt operatsiooni süsteemist
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile)); //File.ReadAllLines loeb info failist, paneb ka faili kinni

/*string[] heroes = {"Rhysand", "Cassian", "Feyre", "Nesta"};*/ //koostab massiivi
/*string[] villains = {"Tamlin", "Hybern", "Amarantha", "Briallyn"};*/ //koostab massiiivi
string[] weapon = { "magic", "harp", "crown", "mask", "cauldron" };

//hero ja villain on massiivid

string hero = GetRandomValueFromArray(heroes); //kutsub funktsiooni välja, hero on muutuja
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with a {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains); //kutsub funktsiooni välja
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with a {villainWeapon} tries to take over the world!");
static string GetRandomValueFromArray(string[] someArray) //GetRandomValueFromArray on enda poolt välja mõeldud nimi funktsioonile, someArray on suvaline väärtus, sinna peab tulema info masiivist 
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex]; //randomStringFromArray on sõne
    return randomStringFromArray;
}
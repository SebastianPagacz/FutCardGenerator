using System.Reflection;
using System.Xml.Linq;

namespace FutCardGenerator;

internal class CardBase
{
    // Card member variables
    private string _name;
    private string _surrname;
    private int _overall;
    private bool _rarity;
    private int _pace;
    private int _shooting;
    private int _passing;
    private int _dribling;
    private int _defending;
    private int _physicality;

    // Card Constructors
    public CardBase(string name, string surrname, bool rarity, int overall, int pace, int shooting, int passing, int dribling, int defending, int physicality)
    {
        Name = name;
        Surrname = surrname;
        Rarity = rarity;
        Overall = overall;
        Pace = pace;
        Shooting = shooting;
        Passing = passing;
        Dribling = dribling;
        Defending = defending;
        Physicality = physicality;
    }

    public CardBase()
    {
        Name = "Unknown";
        Surrname = "Unknown";
        Rarity = false;
        Overall = 1;
        Pace = 1;
        Shooting = 1;
        Passing = 1;
        Dribling = 1;
        Defending = 1;
        Physicality = 1;
    }
    // Card properties using validation methods
    public string Name 
    {
        get => _name;
        init
        {
            _name = StatsValidator.NameLimiter(value, 3, 25);
        }
    }
    public string Surrname 
    { 
        get => _surrname;
        init
        {
            _surrname = StatsValidator.NameLimiter(value, 3, 25);
        } 
    }
    public int Overall 
    { 
        get => _overall; 
        init
        {
            _overall = StatsValidator.StatLimiter(value);
        }
    }
    public bool Rarity 
    { 
        get => _rarity; 
        init => _rarity = value; 
    }
    public int Pace 
    { 
        get => _pace; 
        init
        {
            _pace = StatsValidator.StatLimiter(value);
        }
    }
    public int Shooting 
    { 
        get => _shooting;
        init
        {
            _shooting = StatsValidator.StatLimiter(value);
        } 
    }
    public int Passing 
    { 
        get => _passing; 
        init
        {
            _passing = StatsValidator.StatLimiter(value);
        } 
    }
    public int Dribling 
    { 
        get => _dribling; 
        init
        {
            _dribling = StatsValidator.StatLimiter(value);
        } 
    }
    public int Defending 
    { 
        get => _defending; 
        init
        {
            _defending = StatsValidator.StatLimiter(value);
        } 
    }
    public int Physicality 
    { 
        get => _physicality; 
        init
        {
            _physicality = StatsValidator.StatLimiter(value);
        }
    }

    // Card methods
    //Calculates card's level
    public string CalculateLevel(int overall)
    {
        if (overall < 65)
        {
            return "Bronze";
        }
        if (overall < 75)
        {
            return "Silver";
        }
        return "Gold";
    }

    //Displays information about a card
    public void Info()
    {
        Console.WriteLine($"Name: {Name} Surrname: {Surrname} \nRarity {Rarity} Level {CalculateLevel(Overall)} \nPac {Pace} Dri {Dribling} \nSho {Shooting} Def {Defending} \nPas {Passing} Phy {Physicality}"); 
    }
}

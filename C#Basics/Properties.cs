class Human
{
    byte age = 23;

    public byte Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value > 20 && value < 30)
                age = value;
        }
    }

    // AutoImplemented Property
    public string Name {get ; set; }

    // Readonly Property
    public string Address {get; }

}
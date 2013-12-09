using System;

class People
{
    string fName;
    string lName;

    public string FName
    {
        get { return this.fName; }
        private set { this.fName = value; }
    }
    public string LName
    {
        get { return this.lName; }
        private set { this.lName = value; }
    }

    protected People(string fName, string lName)
    {
        if (String.IsNullOrWhiteSpace(fName) || fName.Length < 2)
        {
            throw new ArgumentException("First name cannot be null or empty.");
        }

        if (String.IsNullOrWhiteSpace(lName) || lName.Length < 2)
        {
            throw new ArgumentException("Last name cannot be null or empty.");
        }

        this.FName = fName;
        this.LName = lName;
    }

    public override string ToString()
    {
        return String.Format("{0} {1}", this.FName, this.LName);
    }
}
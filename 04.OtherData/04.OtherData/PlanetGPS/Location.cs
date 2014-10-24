using System;
using PlanetGPS;

public struct Location
{
    private double _latitude;
    private double _longitude;
    private Planet _planet;

    public double Latitude
    {
        get
        {
            return this._latitude;
        }

        set
        {
            this._latitude = value;
        }
    }

    public double Longitude
    {
        get
        {
            return this._longitude;
        }

        set
        {
            this._longitude = value;
        }
    }

    public Planet Planet 
    {
        get
        {
            return this._planet;
        }

        set
        {
            this._planet = value;
        }
    }

    public Location(double latitude, double longitude, Planet planet) : this()
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1} - {2}", this._latitude, this._longitude, this._planet);
    }
}

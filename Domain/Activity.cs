using System;

namespace Domain;

public class Activity
{
    //this is our entity
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Title { get; set; }  //question mark? to make the title nullable
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public bool IsCancelled { get; set; }

    //location props

    public required string City { get; set; }
    public required string Venue { get; set; } //bulusma yeri
    public double Latitude { get; set; } //enlem
    public double Longitude { get; set; }  //boylam
}

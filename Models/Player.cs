namespace P04DomainMonopolyV1.Models
{
  using System;
  using System.ComponentModel.DataAnnotations.Schema;
  using P04DomainMonopolyV1.Interfaces;

  /*
  Player represents a person playing in a game  
  */
  public class Player
  {
    public int Id { get; set; }

    // Name of the player
    public string Name { get; set; }

    // What game are we linked to
    public Game Game { get; set; }

    // How many doubles has the player rolled
    // 
    // Player_DoublesThrownQuery
    public int DoublesThrown() { throw new NotImplementedException(); }

    // What position (square) is the player currently on
    // 
    // Squares are in an ordered sequence of 40 squares from 0-39
    public int CurrentPosition { get; set; }

    // A player is either free or in jail for a period of time  
    public JailState JailState { get; set; }

    [NotMapped]
    public virtual Dice CurrentRole { get; set; }
  }
}

using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class Giraffe:Giraffa
  {
    public Giraffe(string name)
    {
      this.speciesName = "Giraffa camelopardalis";
      this.commonName = "Giraffe";
      this.name = name;
    }
    public string neckLength{ get; set; }

    public override string animalMessage()
    {
      return $"{base.animalMessage()}.- He lives in {base.region}\n Oh, don't forget his neck is {this.neckLength} long! Whoa!";
    } 

  }
}

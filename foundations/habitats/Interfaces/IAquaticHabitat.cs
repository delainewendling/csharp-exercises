public interface IAquaticHabitat
  {
    void empty();
    void fill();
    bool freshwater {get; set;}
    double temperature {get; set;}
    double volume { get; set; }
  }
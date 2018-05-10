namespace CarBMW
{
  public class Car
  {
    private string model;
    private int modelNumber;

    public Car(string model, int modelNumber)
    {
      this.model = model;
      this.modelNumber = modelNumber;
    }

    public string Model
    {
      get { return model; }
      set { model = value; }
    }

    public int ModelNumber
    {
      get { return modelNumber; }
      set { modelNumber = value; }
    }

    public override string ToString()
    {
      return "On that WebSite: " + modelNumber + " " + model;
    }
  }
}
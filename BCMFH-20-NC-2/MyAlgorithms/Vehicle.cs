namespace MyAlgorithms
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public static Vehicle Parse(string argument)
        {
            string[] csvArg = argument.Split(',');

            if (csvArg.Length != 9)
                throw new FormatException("Incorrect format argument");

            Vehicle result = new Vehicle();

            result.Make = csvArg[0];
            result.Model = csvArg[1];
            result.Cylinder = byte.Parse(csvArg[2]);
            result.Engine = float.Parse(csvArg[3]);
            result.Drive = csvArg[4];
            result.Transmission = csvArg[5];
            result.City = byte.Parse(csvArg[6]);
            result.Combined = byte.Parse(csvArg[7]);
            result.Highway = byte.Parse(csvArg[8]);

            return result;
        }
    }
}

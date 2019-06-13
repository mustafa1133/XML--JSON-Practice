using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Lab11_Atoms
{
    public class Atom
    {
        public string Name;
        public string Symbol;
        public int Proton;
        public int Neutron;
        public double Weight;

        public Atom()
        {

        }

        public Atom(string aName, int aProton, int aNeutron, double aWeight, string aSymbol)
        {
            Name = aName;
            Proton = aProton;
            Neutron = aNeutron;
            Weight = aWeight;
            Symbol = aSymbol;
        }


        public static Atom Parse(string line)
        {
            string[] array = line.Split();


            if (array.Length== 5)
                {
                    Atom aAtom = new Atom(array[0], Convert.ToInt32(array[1]), Convert.ToInt32(array[2]), Convert.ToDouble(array[3]), array[4]);
                    return aAtom;
                }
            else
            {
                throw new Exception("you must have 5 words");
            }
           
        }

       public static void AddElements(ref Atom[] elements)
        {
            elements[0] = (Atom.Parse("Hydrogen 1 0 1.0079 H"));
            elements[1] = (Atom.Parse("Helium 2 2 4.0026 He"));
            elements[2] = (Atom.Parse("Lithium 3 4 6.941 Li"));
            elements[3] = (Atom.Parse("Beryllium 4 5 9.0122 Be"));
            elements[4] = (Atom.Parse("Boron 5 6 10.811 B"));
            elements[5] = (Atom.Parse("Carbon 6 6 12.0107 C"));
            elements[6] = (Atom.Parse("Nitrogen 7 7 14.0067 N"));
            elements[7] = (Atom.Parse("Oxygen 8 8 15.9994 O"));
            elements[8] = (Atom.Parse("Fluorine 9 10 18.9984 F"));
            elements[9] = (Atom.Parse("Neon 10 10 20.1797 Ne"));
            elements[10] = (Atom.Parse("Sodium 11 12 22.9897 Na"));
            elements[11] = (Atom.Parse("Magnesium 12 12 24.305 Mg"));
            elements[12] = (Atom.Parse("Aluminum 13 14 26.9815 Al"));
            elements[13] = (Atom.Parse("Silicon 14 14 28.0855 Si"));
            elements[14] = (Atom.Parse("Phosphorus 15 16 30.9738 P"));
            elements[15] = (Atom.Parse("Sulfur 16 16 32.065 S"));
            elements[16] = (Atom.Parse("Chlorine 17 18 35.453 Cl"));
            elements[17] = (Atom.Parse("Potassium 19 20 39.0983 K"));
            elements[18] = (Atom.Parse("Argon 18 22 39.948 Ar"));
            elements[19] = (Atom.Parse("Calcium 20 20 40.078 Ca"));
            elements[20] = (Atom.Parse("Scandium 21 24 44.9559 Sc"));
            elements[21] = (Atom.Parse("Titanium 22 26 47.867 Ti"));
            elements[22] = (Atom.Parse("Vanadium 23 28 50.9415 V"));
            elements[23] = (Atom.Parse("Chromium 24 28 51.9961 Cr"));
            elements[24] = (Atom.Parse("Manganese 25 30 54.938 Mn"));
            elements[25] = (Atom.Parse("Iron 26 30 55.845 Fe"));
            elements[27] = (Atom.Parse("Nickel 28 31 58.6934 Ni"));
            elements[26] = (Atom.Parse("Cobalt 27 32 58.9332 Co"));
            elements[28] = (Atom.Parse("Copper 29 35 63.546 Cu"));
            elements[29] = (Atom.Parse("Zinc 30 35 65.39 Zn"));
            elements[30] = (Atom.Parse("Gallium 31 39 69.723 Ga"));
            elements[31] = (Atom.Parse("Germanium 32 41 72.64 Ge"));
            elements[32] = (Atom.Parse("Arsenic 33 42 74.9216 As"));
            elements[33] = (Atom.Parse("Selenium 34 45 78.96 Se"));
            elements[34] = (Atom.Parse("Bromine 35 45 79.904 Br"));
            elements[35] = (Atom.Parse("Krypton 36 48 83.8 Kr"));
            elements[36] = (Atom.Parse("Rubidium 37 48 85.4678 Rb"));
            elements[37] = (Atom.Parse("Strontium 38 50 87.62 Sr"));
            elements[38] = (Atom.Parse("Yttrium 39 50 88.9059 Y"));
            elements[39] = (Atom.Parse("Zirconium 40 51 91.224 Zr"));
            elements[40] = (Atom.Parse("Niobium 41 52 92.9064 Nb"));
            elements[41] = (Atom.Parse("Molybdenum 42 54 95.94 Mo"));
            elements[42] = (Atom.Parse("Technetium 43 55 98 Tc"));
            elements[43] = (Atom.Parse("Ruthenium 44 57 101.07 Ru"));
            elements[44] = (Atom.Parse("Rhodium 45 58 102.9055 Rh"));
            elements[45] = (Atom.Parse("Palladium 46 60 106.42 Pd"));
            elements[46] = (Atom.Parse("Silver 47 61 107.8682 Ag"));
            elements[47] = (Atom.Parse("Cadmium 48 64 112.411 Cd"));
            elements[48] = (Atom.Parse("Indium 49 66 114.818 In"));
            elements[49] = (Atom.Parse("Tin 50 69 118.71 Sn"));
            elements[50] = (Atom.Parse("Antimony 51 71 121.76 Sb"));
            elements[51] = (Atom.Parse("Iodine 53 74 126.9045 I"));
            elements[52] = (Atom.Parse("Tellurium 52 76 127.6 Te"));
            elements[53] = (Atom.Parse("Xenon 54 77 131.293 Xe"));
            elements[54] = (Atom.Parse("Cesium 55 78 132.9055 Cs"));
            elements[55] = (Atom.Parse("Barium 56 81 137.327 Ba"));
            elements[56] = (Atom.Parse("Lanthanum 57 82 138.9055 La"));
            elements[57] = (Atom.Parse("Cerium 58 82 140.116 Ce"));
            elements[58] = (Atom.Parse("Praseodymium 59 82 140.9077 Pr"));
            elements[59] = (Atom.Parse("Neodymium 60 84 144.24 Nd"));
            elements[60] = (Atom.Parse("Promethium 61 84 145 Pm"));
            elements[61] = (Atom.Parse("Samarium 62 88 150.36 Sm"));
            elements[62] = (Atom.Parse("Europium 63 89 151.964 Eu"));
            elements[63] = (Atom.Parse("Gadolinium 64 93 157.25 Gd"));
            elements[64] = (Atom.Parse("Terbium 65 94 158.9253 Tb"));
            elements[65] = (Atom.Parse("Dysprosium 66 97 162.5 Dy"));
            elements[66] = (Atom.Parse("Holmium 67 98 164.9303 Ho"));
            elements[67] = (Atom.Parse("Erbium 68 99 167.259 Er"));
            elements[68] = (Atom.Parse("Thulium 69 100 168.9342 Tm"));
            elements[69] = (Atom.Parse("Ytterbium 70 103 173.04 Yb"));
            elements[70] = (Atom.Parse("Lutetium 71 104 174.967 Lu"));
            elements[71] = (Atom.Parse("Hafnium 72 106 178.49 Hf"));
            elements[72] = (Atom.Parse("Tantalum 73 108 180.9479 Ta"));
            elements[73] = (Atom.Parse("Tungsten 74 110 183.84 W"));
            elements[74] = (Atom.Parse("Rhenium 75 111 186.207 Re"));
            elements[75] = (Atom.Parse("Osmium 76 114 190.23 Os"));
            elements[76] = (Atom.Parse("Iridium 77 115 192.217 Ir"));
            elements[77] = (Atom.Parse("Platinum 78 117 195.078 Pt"));
            elements[78] = (Atom.Parse("Gold 79 118 196.9665 Au"));
            elements[79] = (Atom.Parse("Mercury 80 121 200.59 Hg"));
            elements[80] = (Atom.Parse("Thallium 81 123 204.3833 Tl"));
            elements[81] = (Atom.Parse("Lead 82 125 207.2 Pb"));
            elements[82] = (Atom.Parse("Bismuth 83 126 208.9804 Bi"));
            elements[83] = (Atom.Parse("Polonium 84 125 209 Po"));
            elements[84] = (Atom.Parse("Astatine 85 125 210 At"));
            elements[85] = (Atom.Parse("Radon 86 136 222 Rn"));
            elements[86] = (Atom.Parse("Francium 87 136 223 Fr"));
            elements[87] = (Atom.Parse("Radium 88 138 226 Ra"));
            elements[88] = (Atom.Parse("Actinium 89 138 227 Ac"));
            elements[89] = (Atom.Parse("Protactinium 91 140 231.0359 Pa"));
            elements[90] = (Atom.Parse("Thorium 90 142 232.0381 Th"));
            elements[91] = (Atom.Parse("Neptunium 93 144 237 Np"));
            elements[92] = (Atom.Parse("Uranium 92 146 238.0289 U"));
            elements[94] = (Atom.Parse("Americium 95 148 243 Am"));
            elements[93] = (Atom.Parse("Plutonium 94 150 244 Pu"));
            elements[95] = (Atom.Parse("Curium 96 151 247 Cm"));
            elements[96] = (Atom.Parse("Berkelium 97 150 247 Bk"));
            elements[97] = (Atom.Parse("Californium 98 153 251 Cf"));
            elements[98] = (Atom.Parse("Einsteinium 99 153 252 Es"));
            elements[99] = (Atom.Parse("Fermium 100 157 257 Fm"));
            elements[100] = (Atom.Parse("Mendelevium 101 157 258 Md"));
            elements[101] = (Atom.Parse("Nobelium 102 157 259 No"));
            elements[103] = (Atom.Parse("Rutherfordium 104 157 261 Rf"));
            elements[102] = (Atom.Parse("Lawrencium 103 159 262 Lr"));
            elements[104] = (Atom.Parse("Dubnium 105 157 262 Db"));
            elements[106] = (Atom.Parse("Bohrium 107 157 264 Bh"));
            elements[105] = (Atom.Parse("Seaborgium 106 160 266 Sg"));
            elements[108] = (Atom.Parse("Meitnerium 109 159 268 Mt"));
            elements[109] = (Atom.Parse("Roentgenium 111 161 272 Rg"));
            elements[107] = (Atom.Parse("Hassium 108 169 277 Hs"));
           // elements[108] = (Atom.Parse("Hassium 108 169 277 Hs Extra Tokens"));
        }


        public static void DisplayAllElemetns(Atom[] elements)
        {
            foreach (Atom item in elements)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Save(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))// used to create a file with the filename in the method
            {
                XmlSerializer XML = new XmlSerializer(typeof(Atom));// used to create a serializable object
                XML.Serialize(stream, this);// serializes the object

            }
        }

        static public Atom Load(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open))// used to open a file with the filename in the method
            {
                XmlSerializer XML = new XmlSerializer(typeof(Atom));// used to open a serializable object
                return (Atom)XML.Deserialize(stream); //return the deserialized object

            }
        }

        public static void SaveAll(string fileName, Atom[] elements)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))// used to create a file with the filename in the method
            {
                XmlSerializer XML = new XmlSerializer(typeof(Atom[]));// used to create a serializable object
                XML.Serialize(stream,elements);// serializes the object

            }
        }

        static public Atom[] LoadAll(string filename)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(Atom[]));
                return (Atom[])XML.Deserialize(stream);
            }
        }


        static public void SaveJson(string fileName, Atom element)
        {
            FileStream fileOut= new FileStream(fileName,FileMode.Create, FileAccess.Write);//creates a file to write to
            StreamWriter writer = new StreamWriter(fileOut); // creates a stream so you can write
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });// using json serializer to format the object
            serializer.Serialize(writer, element);// serializing object
            writer.Close();
            fileOut.Close();

        }

        static public Atom LoadJson(string fileName)
        {
            Atom result = null;// place holder for returned object
            FileStream fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);// used to open the files
            StreamReader reader= new StreamReader(fileIn);// used to read from the file
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });// used to format the file
            result = serializer.Deserialize(reader, typeof(Atom)) as Atom;// used to deserialize
            reader.Close();
            fileIn.Close();

            return result;//returns the object

        }

        static public void SaveAllJson(string fileName, Atom[] element)
        {
            FileStream fileOut = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileOut);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });
            serializer.Serialize(writer, element);
            writer.Close();
            fileOut.Close();
        }

        static public Atom [] LoadAllJson(string FileName)   
        {
            Atom[] result = null;
            FileStream fileIn = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileIn);
            JsonSerializer deSerializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });
            result=deSerializer.Deserialize(reader, typeof(Atom[])) as Atom[];
            reader.Close();
            fileIn.Close();
            return result;
        }

        public string GetInfo()
        {
            return $"{Name}  {Proton}  {Neutron}  {Weight}  {Symbol}";
        }
    }
}

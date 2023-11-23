// See https://aka.ms/new-console-template for more information
var StudentNames = new string[]

{
    "Ismail Adegbite","Ololade Williams", "Ibraheem Afolaranmi", "Omobolanle Makanjuola", "Aishat Afolabi", "Chioma Bright",
    "Divine Omaka", "Funke Ayeni","Ojo Rachael", "Mantas Joe"
};


List<int> studentAge = new List<int>();
Random random = new Random();

for (int i = 0; i < StudentNames.Length; i++)
{
    studentAge.Add(random.Next(15,22);
}
string Age18yearoldstudentpresent=studentAge.Contains(18)? "True":"False";

Console.WriteLine("Is there any Student who is 18 years old?"+ " "+ Age18yearoldstudentpresent);
Console.WriteLine("\n");


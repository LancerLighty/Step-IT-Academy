using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        //1
        Student studentToJson = new Student() { Name = "tekle", Id = "DG8E30G5HD" };
        string studentjson = JsonConvert.SerializeObject(student);
        Console.WriteLine(studentjson);
        Student deserializedStudent = JsonConvert.DeserializeObject<Student>(studentjson);
        //2
        Student studentToXml = new Student() { Name = "tekle", Id = "GSOG946OJ093335" };
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
        using (TextWriter xmlWriter = new StreamWriter("studentToXml.xml"))
        {
            xmlSerializer.Serialize(xmlWriter, studentToJson);
        }
        using (TextReader xmlReader = new StreamReader("studentToXml.xml"))
        {
            Student? deserializedStudentToXml = xmlSerializer.Deserialize(xmlReader) as Student;
            Console.WriteLine(deserializedStudentToXml.Name + " " + deserializedStudentToXml.Id);
        }
        //3
        Student studentToBinary = new Student() { Name = "tekle", Id = "GSOG946OJ093335" };
        using (FileStream fs = new FileStream("data.dat", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, studentToJson);
        }
    }
}
class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
}
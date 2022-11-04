namespace Just_IEnumerable
{
    internal class Program
    {
        /// <summary>
        /// Реализация стандартных интерфейсов IEnumerable, IEnumerator
        /// В разработанном ранее приложении «Академическая группа» 
        /// предусмотреть реализацию стандартных интерфейсов IEnumerable
        /// классом Academy_Group.
        /// В классе Main_Class продемонстрировать перебор коллекции (объекта 
        /// класса Academy_Group) с помощью оператора цикла foreach
        /// </summary>
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Иван", "Иванов", 20, "+380-00-000-00-00", 5.5, "0а");
            students[1] = new Student("Петр", "Петров", 21, "+380-00-000-00-01", 4.5, "0а");
            students[2] = new Student("Сидор", "Сидоров", 22, "+380-00-000-00-02", 4.4, "0а");
            students[3] = new Student("Андрей", "Андреев", 23, "+380-00-000-00-03", 4.3, "0а");
            students[4] = new Student("Алексей", "Алексеев", 24, "+380-00-000-00-04", 4.2, "0а");

            foreach (var student in students)
                Console.WriteLine(student);

            Console.WriteLine();

            AcademyGroup ag = new AcademyGroup(students);
            foreach (var student in ag)
                Console.WriteLine(student);
        }
    }
}
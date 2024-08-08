using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Controller
    {
        List<Student> students = new List<Student>();
        Menu menu = new Menu();
        public void createStudents()
        {
            bool check = true;
            while (check)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập vào id học sinh: ");
                string id = Console.ReadLine();
                Console.WriteLine("Nhập vào tên học sinh: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhập vào Học kỳ: ");
                int semester = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập vào tên khoá học: ");
                string courseName = Console.ReadLine();
                Student student = new Student(id, name, semester, courseName);
                students.Add(student);
                int count = 0;
                try
                {
                    // Ghi dữ liệu vào tệp
                    using (StreamWriter saveStudent = new StreamWriter("StudentList.txt", true)) // Mở tệp ở chế độ thêm
                    {
                        foreach (var element in students)
                        {
                            saveStudent.WriteLine(element);
                            count++;
                            Console.WriteLine("Add student " + count + " Successfully! ");
                        }
                    }

                    using (StreamReader readText = new StreamReader("StudentList.txt"))
                    {
                        // Ghi dữ liệu vào tệp

                        var line = readText.ReadLine();
                        while ((line = readText.ReadLine()) != null)
                        {
                            if (count >= 10)
                            {
                                bool choice2 = true;
                                Console.WriteLine("Do you want to continue (Y/N)? Choose Y to continue, N to return main screen.");
                                char choice = char.Parse(Console.ReadLine().ToUpper());
                                if (choice == 'Y')
                                {
                                    check = true;
                                }
                                else if (choice == 'N')
                                {
                                    menu.homeMenu();
                                    check = false;
                                    return; // Dùng break chỉ dừng được vòng lặp trong khi dùng return sẽ kết thúc hoàn toàn việc thực thi của phương thức đó
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice! Please choose 'Y' or 'N' ");
                                    Console.WriteLine();
                                    choice2 = true;
                                }
                            }
                            check = true;
                        }
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static List<Student> FindAndSortByName(List<Student> students, string keyword)
        {
            var studentAfterSort = students.Where(p => p.studentName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            studentAfterSort.Sort(new NameCompare());
            return studentAfterSort;
        }

        public void Function2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào tên (hoặc một phần tên) bạn cần tìm kiếm: ");
            string keywword = Console.ReadLine();
            try
            {
                using (StreamReader checkFile = new StreamReader("StudentList.txt"))
                {
                    string line;
                    while ((line = checkFile.ReadLine()) != null)
                    {
                        var data = line.Split('/');
                        if (data.Length == 4)
                        {
                            string id = data[0].Trim();
                            string name = data[1].Trim();
                            int semester = int.Parse(data[2].Trim());
                            string courseName = data[3].Trim();
                            students.Add(new Student(id, name, semester, courseName));
                        }

                    }
                }
            }
            catch (Exception ex)
            {               
                    Console.WriteLine("Error! " + ex.Message); // đang lỗi ko tìm thấy tệp chỗ này
                }
                var FindAndSortStudent = FindAndSortByName(students, keywword);
                Console.WriteLine("Kết quả tìm kiếm (id / tên / kì học / tên khoá học): ");
                

                if (students.Count == 0)
                {
                Console.WriteLine();
                Console.WriteLine("Không có học sinh nào được tìm thấy!");
                }
                else
                {
                    foreach (var studentSort in FindAndSortStudent)
                    {
                    Console.WriteLine();
                    Console.WriteLine(studentSort);
                    }
                }            
        }
    }
}


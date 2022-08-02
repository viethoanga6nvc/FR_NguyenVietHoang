using Polymorphism;

List<Scientist> scientists = new()
{
    new Scientist(1, "zxc", 1478, "qwer", "sda", 8, 10, 8),
    new Scientist(2, "vbn", 1235, "fsfs", "vdr", 2, 22, 9)
};
List<Manager> managers = new()
{
    new Manager(1, "sds", 7894, "sdfsc", "tbd", 12, 1),
    new Manager(2, "azf", 1239, "rgfvv", "yhg", 22, 9)
};
List<LabStaff> labStaffs = new()
{
    new LabStaff(1, "123", 1987, "efvdcc", 146),
    new LabStaff(2, "ere", 1932, "tfvbds", 100)
};

int opt;
do
{
    Console.WriteLine("**********Chuong trinh**********");
    Console.WriteLine("1: Nhap doi tuong");
    Console.WriteLine("2: Xuat danh sach");
    Console.WriteLine("3: Thong ke luong");
    Console.WriteLine("4: Thoat");
    Console.Write("Lua chon: ");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 1:
            Nhap();
            break;
        case 2:
            Xuat();
            break;
        case 3:
            ThongKe();
            break;
        case 4:
            Console.WriteLine("Thoat chuong trinh!");
            break;
        default:
            Console.WriteLine("Lua chon sai!\nMoi nhap lai!");
            break;
    }

} while (opt != 4);
void ThongKe()
{
    double sumSalary = 0;
    Console.Write("Tong luong da tra cho cac nha khoa hoc: ");
    foreach (var staff in scientists)
    {
        sumSalary += staff.Salary();
    }
    Console.WriteLine(sumSalary);
    sumSalary = 0;
    Console.Write("Tong luong da tra cho cac nha quan ly: ");
    foreach (var staff in managers)
    {
        sumSalary += staff.Salary();
    }
    Console.WriteLine(sumSalary);
    sumSalary = 0;
    Console.Write("Tong luong da tra cho cac nha nhan vien phong thi nghiem: ");
    foreach (var staff in labStaffs)
    {
        sumSalary += staff.Salary;
    }
    Console.WriteLine(sumSalary);
}

void Xuat()
{
    Console.WriteLine("_-*-_Nha khoa hoc_-*-_");
    Console.WriteLine($"{"ID",5}{"Name",10}{"BirthYear",10}{"Degree",15}{"Position",10}" +
        $"{"NumOfArticlesInMonth",25}{"NumOfWorkingDayInMonth",25}{"Wage",10}{"Salary",8}");
    foreach (Scientist item in scientists)
    {
        item.Output();
    }

    Console.WriteLine("_-*-_Nha quan ly_-*-_");
    Console.WriteLine($"{"ID",5}{"Name",10}{"BirthYear",10}{"Degree",15}{"Position",10}" +
        $"{"NumOfWorkingDayInMonth",25}{"Wage",10}{"Salary",8}");
    foreach (Manager item in managers)
    {
        item.Output();
    }

    Console.WriteLine("_-*-_Nhan vien phong thi nghiem_-*-_");
    Console.WriteLine($"{"ID",5}{"Name",10}{"BirthYear",10}{"Degree",15}{"Salary",8}");
    foreach (LabStaff item in labStaffs)
    {
        item.Output();
    }
}

void Nhap()
{
    do
    {
        Console.WriteLine("++++++++++Nhap doi tuong++++++++++");
        Console.WriteLine("1: Nha khoa hoc");
        Console.WriteLine("2: Nha quan ly");
        Console.WriteLine("3: Nhan vien phong thi nghiem");
        Console.WriteLine("4: Thoat nhap");
        Console.Write("Lua chon: ");
        opt = int.Parse(Console.ReadLine());
        switch (opt)
        {
            case 1:
                Scientist scientist = new();
                scientist.Input();
                scientists.Add(scientist);
                break;
            case 2:
                Manager manager = new();
                manager.Input();
                managers.Add(manager);
                break;
            case 3:
                LabStaff staff = new();
                staff.Input();
                labStaffs.Add(staff);
                break;
            case 4:
                Console.WriteLine("Thoat nhap!");
                break;
            default:
                Console.WriteLine("Lua chon sai!\nMoi nhap lai!");
                break;
        }
    } while (opt != 4);
}
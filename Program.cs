using tpmodul5_1302213109;

String Nama = Console.ReadLine();
HaloGeneric hg = new HaloGeneric();
hg.SapaUser(Nama);

DataGeneric<String> dg = new DataGeneric<String>("1302213109");
dg.PrintData();
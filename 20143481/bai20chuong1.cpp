#include <iostream>
#include <fstream>
#include <iostream>
using namespace std;
void ghiSoChan(ofstream &GhiSo)
{
 int dem = 0;
 for(int a = 1; a <= 100; a++)
{
if(a%2 == 0)
{
 dem ++;
GhiSo<<a;
if(dem % 5 == 0)
 {
 GhiSo<<"\n";
 }
if(dem % 5 != 0)
 {
 GhiSo<<"\t";
 }
}
}
 cout<<"\n So Chan: "<<dem;
}

int main()
{
 ofstream GhiSo("Ghi So Chan Le.txt");
 ghiSoChan(GhiSo);
 GhiSo<<"\n";
 GhiSo.close();
 system("pause");
 return 0;
}


#include <iostream>
#include <fstream>
#include <time.h>
#include <stdlib.h>
using namespace std;
void taofile();
void docfile();
void sapxep(int A[],int n);
void ghifile();
int main()
{
	int A[10000],n;
	taofile();
	docfile();
	sapxep(A,n);
	ghifile();
}
void taofile()
{
	fstream output;
	output.open("songuyen.inp",ios::out|ios::binary);
	if(output)
	{
		int A[10];
		int n=1000;
		srand((unsigned)time(NULL));
		for(int i=1;i<=n;i++)
		{
			for(int j=0;j<10;j++)
			{
				A[j]=rand()%10;
				cout << A[j] << " ";
			}
			output.write(reinterpret_cast<char *>(&A),sizeof(A));
			output.write("\n",1);
		}
		output.close();
	}
}
void docfile()
{
	fstream input("songuyen.inp",ios::in|ios::binary);
	if(!input)
	{
		cout << "Khong mo duoc file";
		exit(0);
	}
	int n=0;
	int A[10000];
	while(true)
	{
		int B[10];
		input.read(reinterpret_cast<char *>(&B),sizeof(B));
		char c;
		input.read(reinterpret_cast<char *>(&c),sizeof(c));
		if(input.eof())
		{
			break;
		}
		for(int i=0;i<10;i++)
		{
			A[n]=B[i];
			n++;
		}
	}
	input.close();
}
void sapxep(int A[],int n)
{
	for(int i=0;i<9999;i++)
	{
		for(int j=i+1;j<9999;j++)
		{
			if(A[i]>A[j])
			{
				int t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void ghifile()
{
	fstream output;
	output.open("songuyen.out",ios::out|ios::binary);
	if(output)
	{
		int A[10];
		int n=1000;
		srand((unsigned)time(NULL));
		for(int i=1;i<=n;i++)
		{
			for(int j=0;j<10;j++)
			{
				output << A[j] << " ";
			}
			output.write(reinterpret_cast<char *>(&A),sizeof(A));
			output.write("\n",1);
		}
		sapxep(A,n);
		output.close();
	}
}

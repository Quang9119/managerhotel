#include <iostream>
#include <fstream>
#include <time.h>
#include <stdlib.h>
using namespace std;
void taofile();
void docfile();

int main()
{
	fstream output;
	output.open("songuyen.inp",ios::out|ios::binary);
	if(output)
	{
		int n=10000;
		int B[32768]={0};
		srand((unsigned)time(NULL));
		int d=0;
		while(d<n)
		{
			int x =rand()%32768;
			if(B[x]==0)
			{
				B[x]=1;
				output << x << " ";
				d++;
			}
		}
		output.close();
	}
}

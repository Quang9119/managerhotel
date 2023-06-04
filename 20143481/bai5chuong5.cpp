#include <iostream>
#include <string.h>
using namespace std;
void chuyen10sang2(int n,char KQ[]);
int demsobit1(char KQ[]);

int main()
{
	int n;
	cin >>n;
	char KQ[20];
	chuyen10sang2(n,KQ);
	int dem = demsobit1(KQ);
	cout << dem;
	return 0;
}
void chuyen10sang2(int n,char KQ[])
{
	int d=0;
		while(n>0)
		{
			int x = n%2;
			n/=2;
			KQ[d]=x+'0';
			d++;
		}
		KQ[d]='\0';
		strrev(KQ);
}
int demsobit1(char KQ[])
{
	int dem=0;
	for(int i=0;i<strlen(KQ);i++)
	{
		if(KQ[i]=='1')
		{
			dem++;
		}
	}
	return dem;
}

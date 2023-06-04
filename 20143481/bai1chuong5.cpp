#include <iostream>
#include <string.h>
using namespace std;
void chuyen10sang2(int n,char KQ[]);

int main()
{
	int n;
	cin >>n;
	char KQ[20];
	chuyen10sang2(n,KQ);
	return 0;
}
void chuyen10sang2(int n,char KQ[])
{
	for(int i=1;i<=n;i++)
	{
		int a=i;
		int d=0;
		while(a>0)
		{
			int x = a%2;
			a/=2;
			KQ[d]=x+'0';
			d++;
		}
		KQ[d]='\0';
		strrev(KQ);
		cout << KQ;
		cout << endl;
	}
}

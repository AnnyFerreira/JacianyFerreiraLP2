#include <stdio.h>
#include <string.h>

int main(void)
{
     int i,vr,a,b,resp =0;
     int m[5][7];
     memset(m,0,sizeof(m));

     scanf("%d", &vr);

for (i = 0; i < vr; i++)
{
	scanf("%d %d", &a,&b);
	m[a][b]++;

	if (m[a][b]>1)
	{
		resp =1;
		break;
	}
	
}
 printf("%d", resp);
	
	return 0;
}



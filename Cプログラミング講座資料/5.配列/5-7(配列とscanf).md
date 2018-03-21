```
#include<stdio.h>

int main(){
	
	int i,num[5];
	for(i=0;i<5;i++){
		
		scanf("%d",&num[i]);
		
	}
	
	printf("\n");
	
	for(i=0;i<5;i++){
		
		printf("%d\n",num[i]);
		
	}
	
	return 0;
}
```
#### 以下解説

forと相性のいい理由として、代入が非常に楽というのもあげられる。変数を5個準備して、scanfを5回書くよりも、ループで書くほうがスマートなのがわかるだろう。

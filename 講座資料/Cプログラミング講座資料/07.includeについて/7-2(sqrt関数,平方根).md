```
#include<stdio.h>
#include<math.h>

int main(){
	
	double num;
	
	num = sqrt(2);
	
	printf("%f",num);
	
	return 0;
	
}
```

#### 以下解説
今回は数学関数に含まれている,sqrt関数について  
この関数は受け取った数の平方根（正のみ）になる関数である。  
なので、今回は2の平方根、1.414・・・がnumに入る。  
実際にprintfで表示された値は2の平方根になるのがわかるだろう。
#include "pch.h"
#include "stdio.h"
#include <stdlib.h>
#include <string.h>
#define N 5

int my_strlen(char* c_str)
{
	int count = 0;
	while (*c_str++) ++count;
	return count;
}

int main()
{  
	static char* words[256] = {"elephant", "open", "kengoo", "name", "tick"};    // для проверки можно закомментировать
	//static char* words[256] = {"year", "open", "kengoo", "name", "tick"};      // а это раскомментировать
	for (int i = 0; i < N; i++)
		for (int k = 0; k < N; k++)
		{
			int r = my_strlen((words[i])) - 1;
			if (words[k][0] == words[i][r])
			{
				char* temp = words[i + 1];
				words[i + 1] = words[k];
				words[k] = temp; 
				break;
			}
			else if (words[k][0] != words[i][r] && i + 1 >= N)
			{
				printf("\nERROR\n");
				return 0;
			}  			
		}
	for (int q = 1; words[q] != NULL; q++)
		printf("%s ", words[q]);
	printf("\n");

	return 0;
}
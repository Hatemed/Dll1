#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "MathLibrary.h"
#include <mkl.h>
#include <ctime>

void expo(int n, float a[], float y[], unsigned int result[])
{
    unsigned int start_time = clock();
    vmsExp(n, a, y, VML_HA);
    unsigned int end_time = clock();
    result[0] = end_time - start_time;
}
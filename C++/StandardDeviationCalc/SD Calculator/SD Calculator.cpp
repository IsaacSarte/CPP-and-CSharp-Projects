#include <iostream>
#include <windows.h>
#include <cctype>  
#include <conio.h>
#include <cassert>
#include <cstring>
#include <string>
#include <cmath>

using namespace std;

float findSD(float* array, int count);
float findSDDecimal(float* array2_, int count2_);

int main()
{
	int choice;
	bool isInt = false;
	char terminate = 'N';
	terminate = toupper(terminate);
	char retrn = true;

	do
	{
		cout << "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~      M A I N   M E N U      ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" << endl
			<< "[1] Standard Deviation without Decimal" << endl
			<< "[2] Standard Deviation with Decimal" << endl
			<< "Enter your choice: ";
		cin >> choice;
		isInt = cin.fail();
		if (isInt)
		{
			cout << "Execption is caught!" << endl
				<< "INVALID INPUT. Choice must be a numeric value." << endl << endl;
			cin.clear();
			cin.ignore(5, '\n');
		}
		cout << "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" << endl << endl;
		switch (choice)
		{
		case 1:
			int count, i;
			float inputArray[500];

			cout << "Enter number of elements\n";
			cin >> count;
			cout << "--------------------------------";
			cout << endl;

			cout << "Enter " << count << " elements\n";
			for (i = 0; i < count; i++) {
				cin >> inputArray[i];
			}

			cout << "Standard Deviation = " << findSD(inputArray, count);
			cout << endl;
			cout << "Press any key to continue or N/n to quit." << endl;
			cin >> terminate;
			if (terminate == 'N' || terminate == 'n') // Condition if the inputted character is Y or y
			{
				retrn = false;
				return 0;
				break;
			}
			else if (terminate != 'N' || terminate != 'N') // Condition if the inputted character is not equal to Y or y
			{
				system("CLS"); // Statement. Clearing the screen to return to main menu
			}
			break;
		case 2:
			int count2_, i2_;
			float inputArray2_[500];

			cout << "Enter number of elements\n";
			cin >> count2_;
			cout << "--------------------------------";
			cout << endl;

			cout << "Enter " << count2_ << " elements\n";
			for (i2_ = 0; i2_ < count2_; i2_++) {
				cin >> inputArray2_[i2_];
			}

			cout << "Standard Deviation = " << findSDDecimal(inputArray2_, count2_);
			cout << endl;
			cout << "Press any key to continue or N/n to quit." << endl;
			cin >> terminate;
			if (terminate == 'N' || terminate == 'n') // Condition if the inputted character is Y or y
			{
				retrn = false;
				return 0;
				break;
			}
			else if (terminate != 'N' || terminate != 'N') // Condition if the inputted character is not equal to Y or y
			{
				system("CLS"); // Statement. Clearing the screen to return to main menu
			}
			break;
		default:
			cout << "Invalid Input" << endl;
			retrn = true;
			Sleep(1000);
			system("CLS");
			break;
		}
	} while (retrn = true);
	return 0;
}

// Function to find standard deviation 
float findSD(float* array, int count) {
	float sum = 0.0, sDeviation = 0.0, mean;
	int i;

	for (i = 0; i < count; i++) {
		sum += array[i];
	}
	// Calculating mean 
	mean = sum / count;

	for (i = 0; i < count; ++i) {
		sDeviation += (pow(array[i] - mean, 2)) / (count - 1);
	}

	return sqrt(sDeviation);
}

// Function to find standard deviation with decimal
float findSDDecimal(float* array2_, int count2_) {
	float sum2_ = 0.0, sDeviation2_ = 0.0, mean2_;
	int i2_;

	for (i2_ = 0; i2_ < count2_; i2_++) {
		sum2_ += array2_[i2_];
	}
	// Calculating mean 
	mean2_ = sum2_ / count2_;

	for (i2_ = 0; i2_ < count2_; ++i2_) {
		sDeviation2_ += pow(array2_[i2_] - mean2_, 2);
	}

	return sqrt(sDeviation2_ / count2_);
}
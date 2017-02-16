### Specs

adjustment for the month
number of leap years since start of century
add these together along with number of years since start of century and day number of month
apply %7 to figure day of the week

January 1st, 2000 (Saturday)
leap year every 4, except on 100, unless also 400

Jan 1st, 2001  366/7

Jan 1st, 2002 1*366 + 1*365

Jan 1st, 2004 2004-2000 = 4

March 1st, 2004
ceil(4/4) = 1

number of leap year*366 + number of non-leap year*365

#### If the date is Jan 1st, 2000, the program return "Saturday"
* Input: Jan 1st, 2000
* Output: "Saturday"

#### If the date is Jan 2nd, 2000, the program return "Sunday"
* Input: Jan 2nd, 2000
* Output: "Sunday"

#### If the date is Jan 8th, 2000, the program return "Saturday"
* Input: Jan 8nd, 2000
* Output: "Saturday"

#### If the date is Jan 9th, 2000, the program return "Sunday"
* Input: Jan 9nd, 2000
* Output: "Sunday"

#### If the date is Feb 1st, 2000, the program return "Tuesday"
* Input: Feb 1st, 2000
* Output: "Tuesday"

array = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
int days
for (int i=1; i< monthInt; i++)
{
  days = days+ array[i-1];
}

#### If the date is Jan 1st, 2001, the program return "Monday"
* Input: Jan 1st, 2000
* Output: "Monday"

#### If the date is Jan 1st, 2005, the program return "Saturday"
* Input: Jan 1st, 2005
* Output: "Saturday"

#### If the date is March 17th, 2005, the program return "Thursday"
* Input: March 17th, 2005
* Output: "Thursday"

#### If the date is March 17th, 1999, the program return "Wednesday"
* Input: March 17th, 1999
* Output: "Wednesday"

#### If the date is Aug 23rd, 1492, the program return "Wednesday"
* Input: March 17th, 1999
* Output: "Wednesday"

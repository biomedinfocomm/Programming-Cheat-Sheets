




#### Statistics with python ####

#----Understanding and visualizing data with python----

## pandas data frame is a data table ##
#-- rows rep cases
#-- columns rep variables

# read data file
df = pd.read_csv("file.csv")
# display all data
df

# display rows and columns of data file
df.shape

# display columns
df.columns

# display data first five rows
df.head()

# display data last five rows
df.tail()

# display basic statistical details
df.describe()

# check variable names data types
df.dtypes
# most commonly dtypes: floating point values (real numbers), integers, strings (text), and date/time values. 

## Numpy ##
# create 3X1 array
a = np.array([a, b, c])
# create 3X2 array
a = np.array([[a, b], [c,d], [e,f]])
# type of array
type(a)
# dimension of array
a.ndim
# shape (row, column) of array
a.shape
# len of array a
len(a)
# print values
a[0], a[1], a[2]

## Visualizing Data ##
# plotting
import seaborn as sns 
# showing plots
import matplotlib.pyplot as plt 

# print first few rows of the data
df.head()
# print the summary statistics for the quantitative variables
df.describe()
# print full summary
df.info()

# filtering with query method
df.query('Country == "US"') # only display US

### Data cleaning ###

# isnull(): Generate a boolean mask indicating missing values
# notnull(): Opposite of isnull()
# dropna(): Return a filtered version of the data
# fillna(): Return a copy of the data with missing values filled or imputed

df.columns = ['a','b','c'] # Renames columns
pd.isnull() # Checks for null Values, Returns Boolean Array
pd.notnull() # Opposite of s.isnull()
df.dropna() # Drops all rows that contain null values
df.dropna(axis=1) # Drops all columns that contain null values
df.dropna(axis=1,thresh=n) # Drops all rows have have less than n non null values
df.fillna(x) # Replaces all null values with x
s.fillna(s.mean()) # Replaces all null values with the mean (mean can be replaced with almost any function from the statistics section)
s.astype(float) # Converts the datatype of the series to float
s.replace(1,'one') # Replaces all values equal to 1 with 'one'
s.replace([1,3],['one','three']) # Replaces all 1 with 'one' and 3 with 'three'
df.rename(columns=lambda x: x + 1) # Mass renaming of columns
df.rename(columns={'old_name': 'new_ name'}) # Selective renaming
df.set_index('column_one') # Changes the index
df.rename(index=lambda x: x + 1) # Mass renaming of index

# check duplicates
df.duplicated()

# check sample rows 
df.sample(a)

# check percentage of missing values
for col in df.columns:
    percentage_missing = np.mean(df[col].isnull())
    print('{} - {}%'.format(col, round(percentage_missing*100)))

# check number of missing data per column
sum_percolumn_missingnan = df.isnull().sum()

# print number of missing data in the total columns
sum_percolumn_missingnan[0:total columns]

# number of total missing values
total_cells = np.product(df.shape)
total_missing = sum_percolumn_missingnan.sum()

# percentage of missing data
(total_missing/total_cells) * 100

# replace all null values (NaN) with 0
df.fillna(0)

# replace all null values (NaN) with ""
df['column name']= df['column name'].fillna("")

# replace 0 or other values with (NaN)
new_df = df.replace([0], np.NaN)
df

# replace 0 or other values with (NaN) using dictionary method
new_df = df.replace([{
    'name of column1': value1 to replace from,
    'name of column2': value2 to replace from,
    'name of column3': value3 to replace from
},np.NaN)
new_df

# replace 0 or other values with (NaN) using dictionary method
new_df = df.replace([{
    value to replace: np.NaN,
    'column variable name to replace': 'new column variable name'
})
new_df


# display unique values
df.nunique
# display data individual column
df['gender'].unique()

# drop irrelevant columns
df = df.drop(['column name1', 'column name2'], axis=1)

# find correlation
corelation = df.corr()


## Seaborn ##

# hue: determines which column in the data frame should be used for colour encoding

## Warnings ##
# ignore warnings
import warnings
warnings.filterwarnings('ignore')

# plotly will work offline
py.offline.init_notebook_mode(connected=True)

# convert date parameter to string format
df['Date'] = df['Date'].astype(str)

# astype(): convert column data type to another data type

# convert date into date time format
df['Date'] = pd.to_datetime(df['Date'])
# Print full summary
df.info()

## Save Static Plot ##
# need to open anaconda prompt and type 
# conda install -c plotly plotly-orca==1.2.1 psutil requests 
# will create a images folder

import os
# mkdir means make a directory
if not os.path.exists('images'):
    os.mkdir('images')
fig
# save image
fig.write_image("images/fig.png")




# count the value of each category
df = df.categorycolumn.value_counts()
df

# find population proportion
# count the value of each category divide each of them with the total population
df / df.sum()
# if contains missing 
df["categorycolumn"] = df.categorycolumn.fillna("Missing")
df = df.categorycolumn.value_counts()
df / df.sum()

# find mean
mean_rbp = df.RestBP.dropna().mean()

# find population proportion of the people who have the higher RestBP than the mean RestBP
len(df[df["RestBP"] > mean_rbp])/len(df)

# Plot the Cholesterol data against the age group
# observe the difference in cholesterol levels in different age groups of people
# Make a new column in the dataset that will return the number of people in the different age groups
df["agegrp"]=pd.cut(df.Age, [29,40,50,60,70,80])

plt.figure(figsize=(12,5))
sns.boxplot(x = "agegrp", y = "Chol", data=df)
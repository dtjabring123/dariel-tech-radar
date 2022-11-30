import vowpalwabbit
import pandas as pd

# generate sample data that could originate from previous random trial, e.g. AB test, for the CB to explore
## data here are equivalent to example in https://github.com/VowpalWabbit/vowpal_wabbit/wiki/Logged-Contextual-Bandit-Example
train_data = [
    {
        "action": 1,
        "cost": 2,
        "probability": 0.4,
        "feature1": "a",
        "feature2": "c",
        "feature3": "",
    },
    {
        "action": 3,
        "cost": 0,
        "probability": 0.2,
        "feature1": "b",
        "feature2": "d",
        "feature3": "",
    },
    {
        "action": 4,
        "cost": 1,
        "probability": 0.5,
        "feature1": "a",
        "feature2": "b",
        "feature3": "",
    },
    {
        "action": 2,
        "cost": 1,
        "probability": 0.3,
        "feature1": "a",
        "feature2": "b",
        "feature3": "c",
    },
    {
        "action": 3,
        "cost": 1,
        "probability": 0.7,
        "feature1": "a",
        "feature2": "d",
        "feature3": "",
    },
]

train_df = pd.DataFrame(train_data)

## add index to df
train_df["index"] = range(1, len(train_df) + 1)
train_df = train_df.set_index("index")

# generate some test data that you want the CB to make decisions for, e.g. features describing new users, for the CB to exploit
test_data = [
    {"feature1": "b", "feature2": "c", "feature3": ""},
    {"feature1": "a", "feature2": "", "feature3": "b"},
    {"feature1": "b", "feature2": "b", "feature3": ""},
    {"feature1": "a", "feature2": "", "feature3": "b"},
]

test_df = pd.DataFrame(test_data)

## add index to df
test_df["index"] = range(1, len(test_df) + 1)
test_df = test_df.set_index("index")

# take a look at dataframes
print(train_df)
print(test_df)


from vowpalwabbit import Workspace

# One we’ve imported vowpalwabbit, we can initialize VW either by passing a command line string (e.g., "--quiet -q ab --l2 0.01") or, in a more python-friendly manner, providing those as named arguments. Here we do the latter.

vw = Workspace(quiet=True, q="ab", l2=0.01)

# VW objects can create examples and train/predict on those examples.

# One way to create an example is to pass a string. This is the equivalent of a string in a VW file. For instance:

ex = vw.example("1 |a two features |b more features here")

# Documentation can be looked at with help or you can look it up in the generated docs.

help(vw.learn)
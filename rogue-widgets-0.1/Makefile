CC=mcs
EXECUTABLE=libRogueWidgets.nbsd.exe
SOURCES=widget.cs \
widgettreenode.cs \
widgettree.cs \
nontextwidget.cs \
labelwidget.cs \
buttonwidget.cs \
callbackfunctor.cs \
imagebuttonwidget.cs \

FLAGS=/reference:System.Drawing.dll /reference:System.Windows

all: $(EXECUTABLE)

$(EXECUTABLE): $(SOURCES)
	@echo compiling...
	${CC}  $(SOURCES) $(FLAGS)

clean:
	rm -f *.o

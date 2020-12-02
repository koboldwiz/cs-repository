CC=mcs
EXECUTABLE=test.nbsd.exe
SOURCES=*.cs \

FLAGS=/reference:System.Drawing.dll /reference:System.Windows

all: $(EXECUTABLE)

$(EXECUTABLE): $(SOURCES)
	@echo compiling...
	${CC}  $(SOURCES) $(FLAGS)

clean:
	rm -f *.o

CC=mcs
EXECUTABLE=test.nbsd.exe
SOURCES=gui.cs \
graphicsdevice.cs \
entity.cs \
entitywidget.cs \
femtowindow.cs \

FLAGS=/reference:System.Drawing.dll /reference:System.Windows.dll

all: $(EXECUTABLE)

$(EXECUTABLE): $(SOURCES)
	@echo compiling...
	${CC}  $(SOURCES) $(FLAGS)

clean:
	rm -f *.o

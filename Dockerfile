# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src


COPY ["DoctorAppointment.RazorPages/DoctorAppointment.RazorPages.csproj", "DoctorAppointment.RazorPages/"]
COPY ["DoctorAppointment.Application/DoctorAppointment.Application.csproj", "DoctorAppointment.Application/"]
COPY ["DoctorAppointment.Domain/DoctorAppointment.Domain.csproj", "DoctorAppointment.Domain/"]
COPY ["DoctorAppointment.Persistence/DoctorAppointment.Persistence.csproj", "DoctorAppointment.Persistence/"]

RUN dotnet restore "DoctorAppointment.RazorPages/DoctorAppointment.RazorPages.csproj"
RUN dotnet restore "DoctorAppointment.Application/DoctorAppointment.Application.csproj"
RUN dotnet restore "DoctorAppointment.Domain/DoctorAppointment.Domain.csproj"
RUN dotnet restore "DoctorAppointment.Persistence/DoctorAppointment.Persistence.csproj"

# Copy everything else and build the project
COPY . ./

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 80
COPY --from=build /src/out .
ENTRYPOINT ["dotnet", "DoctorAppointment.RazorPages.dll"]

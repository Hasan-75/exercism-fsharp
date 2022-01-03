module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule (appointmentDateDescription: string): DateTime =
    DateTime.Parse(appointmentDateDescription)

let hasPassed (appointmentDate: DateTime): bool =
    let comparison = DateTime.Compare(appointmentDate, DateTime.Now);
    comparison < 0

let isAfternoonAppointment (appointmentDate: DateTime): bool =
    appointmentDate.Hour >= 12
    &&
    appointmentDate.Hour < 18

let description (appointmentDate: DateTime): string =
    appointmentDate.ToString()
    |> sprintf "You have an appointment on %s."

let anniversaryDate(): DateTime =
    DateTime(2019, 9, 15, 0, 0, 0)
        .AddYears(DateTime.Now.Year - 2019)
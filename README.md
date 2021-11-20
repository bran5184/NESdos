# NESdos
A command prompt very similar to dos but for NES roms

it's a silly program but for once it actually is somewhat useful
as frontend of sorts

Setup:

**Requirements:**
Microsoft .NET Framework 6.0 redistributable
Windows 7 or later/mono compatible with .NET 6.0

this program calls to fceux and the fceux folder needs to be in C:\fceux in that folder you need a roms folder where the actual roms are stored

**The Roms:**

the actual rom files need to have no spaces in the name as the emulator will only take the other half which tends to be `(U).nes`

example: `Super Mario Bros. (World).nes` doesn't work but `smb.nes` does

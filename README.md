# Laptop Checker

Aplikasi desktop Windows Forms untuk memindai informasi perangkat laptop/komputer dan mengirimkannya ke server dashboard admin.

## Fitur

- Registrasi nama pengguna dan bidang kerja.
- Pemindaian informasi perangkat menggunakan Windows Management Instrumentation (WMI):
  - ID perangkat
  - Nama komputer
  - Manufaktur dan model
  - CPU
  - RAM
  - GPU
  - Media penyimpanan
  - Versi Windows
- Pengiriman data hasil pemindaian ke API melalui HTTP `POST`.
- Tampilan status koneksi dan hasil pengiriman data.
- Penyimpanan ID perangkat lokal agar tetap konsisten untuk perangkat yang sama.

## Teknologi

- .NET 10 Windows Forms
- C# dengan nullable reference types
- `System.Management` untuk membaca informasi hardware melalui WMI
- `HttpClient` dan JSON untuk komunikasi dengan API

## Prasyarat

- Windows 10 atau lebih baru.
- .NET 10 SDK.
- Akses ke server API yang menerima data perangkat.
- Hak akses yang memungkinkan aplikasi membaca informasi WMI perangkat.

## Menjalankan dari Source Code

Dari folder root repository (`Laptop-checker`):

```powershell
dotnet restore .\Laptop-checker\Laptop-checker.csproj
dotnet run --project .\Laptop-checker\Laptop-checker.csproj
```

Atau buka `Laptop-checker.slnx` menggunakan Visual Studio atau VS Code dengan ekstensi C#.

## Konfigurasi API

Konfigurasi berada di `Laptop-checker/appsettings.json` dan disalin otomatis ke folder output saat build.

```json
{
  "Api": {
    "BaseUrl": "http://localhost:8000",
    "DevicesEndpoint": "api/devices"
  }
}
```

URL request dibentuk sebagai berikut:

```text
{BaseUrl}/{DevicesEndpoint}
```

Contoh default:

```text
http://localhost:8000/api/devices
```

Aplikasi juga membaca `appsettings.json` dari folder hasil build. Jika file atau konfigurasi tidak dapat dibaca, aplikasi menggunakan nilai default `http://localhost:3001` dan `api/devices`.

## Alur Penggunaan

1. Jalankan aplikasi.
2. Masukkan nama pengguna.
3. Pilih bidang kerja.
4. Klik tombol **Daftar** untuk membuka dashboard.
5. Klik tombol **Scan** untuk membaca informasi perangkat.
6. Setelah pemindaian berhasil, data dikirim otomatis ke server API.
7. Periksa pesan status untuk mengetahui apakah pengiriman berhasil.

Nama pengguna dan bidang kerja wajib diisi sebelum dashboard dibuka.

## Format Data API

Aplikasi mengirim request `POST` dengan `Content-Type: application/json` dan body berikut:

```json
{
  "user_name": "Nama Pengguna",
  "department": "Bidang Pemerintahan Desa",
  "device_id": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
  "device_name": "NAMA-KOMPUTER",
  "manufacturer": "Manufacturer",
  "model": "Model",
  "cpu": "CPU",
  "ram": "16 GB",
  "gpu": "GPU",
  "storage": "Disk Model (512 GB)",
  "windows_version": "Windows - Version 10.0.XXXXX - Build XXXXX"
}
```

Nilai aktual bergantung pada hardware dan sistem operasi perangkat.

## Penyimpanan ID Perangkat

ID perangkat dibuat satu kali dan disimpan di:

```text
%APPDATA%\LaptopChecker\device.id
```

Selama file tersebut tidak dihapus, pemindaian berikutnya menggunakan ID yang sama.

## Build dan Publish

Build mode Release:

```powershell
dotnet build .\Laptop-checker\Laptop-checker.csproj --configuration Release
```

Profil publish yang tersedia berada di `Laptop-checker/Properties/PublishProfiles/`. Hasil publish dapat digunakan pada komputer Windows yang memenuhi prasyarat runtime/deployment yang dipilih.

## Struktur Utama

```text
Laptop-checker/
|-- Laptop-checker.slnx
|-- Laptop-checker/
    |-- Program.cs              # Entry point aplikasi
    |-- Form1.cs                # Form registrasi pengguna
    |-- DashboardForm.cs        # Pemindaian dan pengiriman data
    |-- DeviceInfo.cs           # Model data perangkat
    |-- DeviceService.cs        # Pembacaan data hardware melalui WMI
    |-- Services/ApiService.cs  # Konfigurasi dan komunikasi API
    |-- appsettings.json        # Konfigurasi endpoint API
    `-- Laptop-checker.csproj   # Konfigurasi project dan dependensi
```

## Catatan Troubleshooting

- **Server tidak terhubung:** pastikan server API aktif dan `BaseUrl` benar.
- **Request menuju endpoint yang salah:** periksa `DevicesEndpoint` dan pastikan tidak menambahkan slash yang tidak diperlukan.
- **Scan gagal:** jalankan aplikasi pada Windows dan pastikan layanan/informasi WMI dapat diakses.
- **ID perangkat berubah:** periksa apakah file `%APPDATA%\LaptopChecker\device.id` terhapus atau profil pengguna berubah.

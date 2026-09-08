using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Laptop_checker
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl;
        private string _devicesEndpoint;
        private readonly string _configPath;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
            _configPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            LoadConfig();
        }

        private void LoadConfig()
        {
            _baseUrl = "http://localhost:3001";
            _devicesEndpoint = "api/devices";

            try
            {
                if (!File.Exists(_configPath)) return;

                var json = File.ReadAllText(_configPath);
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (root.TryGetProperty("Api", out var api))
                {
                    if (api.TryGetProperty("BaseUrl", out var b) && b.GetString() is { Length: > 0 } baseUrl)
                        _baseUrl = baseUrl;

                    if (api.TryGetProperty("DevicesEndpoint", out var e) && e.GetString() is { Length: > 0 } endpoint)
                        _devicesEndpoint = endpoint;
                }
            }
            catch
            {
                // keep defaults
            }
        }

        public string GetBaseUrl() => _baseUrl;

        public string GetDevicesEndpoint() => _devicesEndpoint;

        public void SaveConfig(string baseUrl, string devicesEndpoint = null)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            if (!string.IsNullOrWhiteSpace(devicesEndpoint))
                _devicesEndpoint = devicesEndpoint.Trim('/');

            var obj = new
            {
                Api = new
                {
                    BaseUrl = _baseUrl,
                    DevicesEndpoint = _devicesEndpoint
                }
            };

            var json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_configPath, json);
        }

        public async Task<(bool success, string message)> SendDeviceAsync(DeviceInfo device, string userName, string department = "")
        {
            var payload = new
            {
                user_name = userName,
                department = department,
                device_id = device.DeviceId,
                device_name = device.DeviceName,
                manufacturer = device.Manufacturer,
                model = device.Model,
                cpu = device.CPU,
                ram = device.RAM,
                gpu = device.GPU,
                storage = device.Storage,
                windows_version = device.WindowsVersion
            };

            var url = $"{_baseUrl.TrimEnd('/')}/{_devicesEndpoint.TrimStart('/')}";
            var json = JsonSerializer.Serialize(payload);

            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var resp = await _httpClient.PostAsync(url, content);
                var body = await resp.Content.ReadAsStringAsync();

                if (resp.IsSuccessStatusCode)
                {
                    return (true, $"Berhasil dikirim ke server ({resp.StatusCode})");
                }

                return (false, $"Gagal kirim: {(int)resp.StatusCode} - {body}");
            }
            catch (TaskCanceledException)
            {
                return (false, "Koneksi ke server timeout. Periksa URL server dan pastikan server berjalan.");
            }
            catch (HttpRequestException ex)
            {
                return (false, $"Gagal kirim: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Gagal kirim: {ex.Message}");
            }
        }

        public async Task<string> GetDevicesAsync()
        {
            var url = $"{_baseUrl.TrimEnd('/')}/{_devicesEndpoint.TrimStart('/')}";

            try
            {
                return await _httpClient.GetStringAsync(url);
            }
            catch
            {
                return null;
            }
        }
    }
}

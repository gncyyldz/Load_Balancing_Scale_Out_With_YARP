import http from 'k6/http';

export const options = {
    stages: [
        { duration: '10s', target: 20 }, // İlk 10 saniye boyunca 20 istek
        { duration: '10s', target: 50 }, // Sonraki 10 saniye boyunca 50 istek
        { duration: '1m5s', target: 1000 }, // 1 dakika 5 saniye boyunca 1000 istek
    ],
};

export default function () {

    // GET isteği yapalım
    const response = http.get('https://localhost:7180');

    // Yanıtı kontrol edelim
    //if (response.status === 200) {
    //    console.log(`İstek başarılı👍 Yanıt:`, response.body);
    //} else {
    //    console.log('İstek başarısız👎 Durum kodu:', response.status);
    //}
}
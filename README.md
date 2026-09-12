graph TD
    User["👤 المستخدم / Postman"] -->|"1. يرسل تفاصيل الحجز"| Controller["🎮 BookingController <br/> (الاستقبال / Controller)"]
    
    Controller -->|"2. يمرر البيانات للـ Service"| Service["⚙️ BookingPricingService <br/> (المحرك التنفيذي / Service)"]
    
    subgraph External System ["الذكاء الاصطناعي و الأتمتة"]
        Service -->|"3. يجهز الطلب ويصيغ الـ JSON<br/>4. يتصل عبر HttpClient"| N8N["🤖 n8n + AI <br/> (حساب السعر الديناميكي)"]
        N8N -->|"5. يعيد السعر المحسوب"| Service
    end

    Service -->|"6. يحول النتيجة إلى PricingResponseDto"| Controller
    Controller -->|"7. يرجع النتيجة النهائية"| User
